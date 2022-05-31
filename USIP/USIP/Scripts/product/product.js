angular.module("product", [])
	.directive("product", ["Api", "Authentication", "$uibModal",
		function (api, authentication, $modal) {
			
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
						template: "<edit-product handler='handler' product='product' ></edit-product>"
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
						},
						close: function () {
							modal.close();
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
					getCategorys();
				},
				templateUrl: "Scripts/product/product.html"
			}
		}
	]);