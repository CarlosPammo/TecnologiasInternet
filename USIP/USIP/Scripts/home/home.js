angular.module("home", [])
	.directive("home", ["Api", "Authentication",
		function (api, authentication) {
			return {
				restrict: "E",
				replace: true,
				scope: {},
                link: function (scope) {

				},
				templateUrl: "Scripts/home/home.html"
			}
		}
	]);