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
		"student"
	])
	.controller("AppCtrl", ["$scope",
		function ($scope) {
			// bool hide = true;
			$scope.hide = true;
		}
	])
	.config(["$stateProvider", "$urlRouterProvider",
		function ($stateProvider, $urlRouterProvider) {
			$stateProvider
				.state("home", {
					url: "/home",
					template: "<home></home>"
				})
				.state("student", {
					url: "/student",
					template: "<student></student>"
				})

			$urlRouterProvider.otherwise("/home")
		}
	])
	.service("Api", ["$resource",
		function ($resource) {
			this.student = $resource("../api/student", null, {
				"get": { method: "GET" },
				"post": { method: "POST" },
				"put": { method: "PUT" },
				"delete": { method: "DELETE" }
			});
		}
	]);