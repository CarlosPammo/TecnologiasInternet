angular.module("edit_product", [])
	.directive("editProduct", ["Api",
		function (api) {
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					product: "=",
				
				},

				link: function (scope) {
					function load() {
						api.category.get(
							function (response) {
								scope.categorys = response.categorys;
							}
						);
					}
					load();
				},
				templateUrl: "Scripts/edit_product/edit_product.html"
			}
		}
	]);