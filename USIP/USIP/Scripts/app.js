"use-strict"
angular
	.module("App", [
		//bower modules
		"angular-confirm",
		"ngAnimate",
		"ngCookies",
		"ngIdle",
		"ngMaterial",
		"ngResource",
		"ngRoute",
		"ngSanitize",
		"ui.bootstrap",
		"ui.router",
		//Custome modules
		"home",
		"student",
		"login",
		"menu"
	])
	.controller("AppCtrl", ["Authentication","$scope", "$window", "$location",
		function (authentication, $scope, $window, $location) {
			var existingUser = $window.sessionStorage.getItem("LoggedInUser");
			if (existingUser) {
				var user = angular.fromJson(existingUser);
				angular.extend(authentication.loggedUser, user);
				$http.defaults.headers.common["Authorization"] = "Bearer " + user.access_token;
			} else {
				$location.path("/login")
			}

			$scope.hide = function () {
				return !authentication.isLoggedIn();
			};
		}
	])
	.config(["$stateProvider", "$urlRouterProvider", "$httpProvider",
		function ($stateProvider, $urlRouterProvider, $httpProvider) {
			$httpProvider.interceptors.push("ErrorInterceptor");

			$stateProvider
				.state("home", {
					url: "/home",
					template: "<home></home>"
				})
				.state("student", {
					url: "/student",
					template: "<student></student>"
				})
				.state("login", {
					url: "/login",
					template: "<login></login>"
				});

			$urlRouterProvider.otherwise("/login")
		}
	])
	.service("Api", ["$resource", "$http",
		function ($resource, $http) {
			this.student = $resource("../api/student", null, {
				"get": { method: "GET" },
				"post": { method: "POST" },
				"put": { method: "PUT" },
				"delete": { method: "DELETE" }
			});

			this.token = function (data) {
				return $http({
					method: "POST",
					url: "/Token",
					data: data,
					headers: {
						"Content-Type": "application/x-www-form-urlencoded"
					}
				});
			}
		}
	])
	.factory("Authentication", ["Api", "$http", "$window",
		function (api, $http, $window) {
			var freshUser = function () {
				return {
					username: "",
					access_token: ""
				}
			}
			var authenticatedUser = new freshUser();

			function extend(user) {
				angular.extend(authenticatedUser, user);
			}

			return {
				loggedUser: authenticatedUser,
				token: function (credentials, success, failed) {
					var data = "grant_type=password&username=" + credentials.user + "&password=" + credentials.password;
					api.token(data).then(function (response) {
						extend(response.data);
						$http.defaults.headers.common["Authorization"] = "Bearer " + response.data.access_token;
						$window.sessionStorage.setItem("LoggedInUser", angular.toJson(authenticatedUser));
						success(response);
					}, function () {
						failed();
					})
				},
				isLoggedIn: function () {
					return authenticatedUser.access_token != "";
				},
				loggingOff: function (success) {
					extend(freshUser());
					$window.sessionStorage.removeItem("LoggedInUser")
					delete $http.defaults.headers.common["Authorization"];
					success();
				}
			};
		}
	])
	.factory("ErrorInterceptor", ["$q",
		function ($q) {
			return {
				"responseError": function (response) {
					if ((response.status === 500) && (_.isObject(response.data))) {
						alert(response.data.Message);
					}
					return $q.reject(response);
				}
			};
		}
	]);