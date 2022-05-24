angular.module("login", [])
	.directive("login", ["Authentication", "$location",
		function (authentication, $location) {
			return {
				restrict: "E",
				replace: true,
				scope: {},
				link: function (scope) {
					scope.login = function () {
						authentication.token(scope.credentials,
							function (validated) {
								$location.path("/home");
							},
							function () {
								alert("Invalid User");
							});
					}
				},
				templateUrl: "Scripts/login/login.html"
			}
		}
	]);