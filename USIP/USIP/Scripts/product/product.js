angular.module("product", [])
	.directive("product", [
		function () {
			
			return {
				restrict: "E",
				replace: true,
				scope: {},
				link: function (scope) {
					var modal;
					var config = {
						scope: scope,
						size: "lg",
						backdrop: "static",
						template: "<editProduct handler='handler' product='product'></student>"
					};

					function load() {
						api.product.get(
							function (response) {
								scope.products = response.products;
							}
						);
					}

					scope.openEditor = function () {
						modal = $modal.open(config);
					};

					scope.handler = {
						save: function (data) {
							api.product.post(data,
								function (response) {
									load();
									modal.close();
								}
							);
						}
					}

					scope.edit = function (product) {
						scope.product = product;
						api.product.put(product,
							function (response) {
								load();
								modal.close();
							}
						);
					};

					scope.delete = function (product) {
						api.product.delete(product,
							function () {
								load();
							}
						);
					};


					load();
				},
				templateUrl: "Scripts/product/product.html"
			}
		}
	]);