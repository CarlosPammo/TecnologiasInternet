angular.module("edit_product", [])
	.directive("editProduct", [
		function () {
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					student: "="
				},
				templateUrl: "Scripts/edit_product/edit_product.html"
			}
		}
	]);