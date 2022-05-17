angular.module("home", [])
	.directive("home", [
		function () {
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