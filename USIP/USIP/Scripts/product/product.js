angular.module("product", [])
	.directive("product", [
		function () {
			
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					student: "="
				},
				templateUrl: "Scripts/product/product.html"
			}
		}
	]);