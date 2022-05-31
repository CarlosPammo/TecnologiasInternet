angular.module("category", [])
	.directive("category", ["Api", "Authentication", "$uibModal",
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
						template: "<edit-category handler='handler' category='category'></edit-category>"
					};

					function load() {
						api.category.get(
							function (response) {
								scope.categorys = response.categorys;
							}
						);
					}

					scope.openEditor = function () {
						modal = $modal.open(config);
					};

					scope.handler = {
						save: function (data) {
							api.category.post(data,
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

				

					scope.edit = function (category) {
						scope.category = category;
						api.category.put(category,
							function (response) {
								load();
								modal.close();
							}
						);
					};

					scope.delete = function (category) {
						api.category.delete(category,
							function () {
								load();
							}
						);
					};


					load();
				},
				templateUrl: "Scripts/category/category.html"
			}
		}
	]);