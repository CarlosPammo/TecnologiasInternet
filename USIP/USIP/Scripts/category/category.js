angular.module("category", [])
	.directive("category", [
		function () {
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					product: "="
				},
				templateUrl: "Scripts/category/category.html"
			}
		}
	]);