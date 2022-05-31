angular.module("category", [])
	.directive("category", ["Api", "Authentication", "$uibModal",
		function (api, authentication, $modal) {

			return {
				restrict: "E",
				replace: true,
				scope: {},
				link: function (scope) {
					var modal;
					var categoryEdit;
					var configAdd = {
						scope: scope,
						size: "lg",
						backdrop: "static",
						template: "<edit-category handler='handler' category='category'  ></edit-category>"
					};
					var configEditor = {
						scope: scope,
						size: "lg",
						backdrop: "static",
						template: "<edit-category handler='handlerEdit' category='categoryEdit'  ></edit-category>"
                    }

					function load() {
						api.category.get(
							function (response) {
								scope.categorys = response.categorys;
							}
						);
					}

					scope.openAdd = function () {
						modal = $modal.open(configAdd);
					};

					scope.openEditor = function (category) {
						
						categoryEdit = category;
						modal = $modal.open(configEditor);
                    }

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
					

					scope.handlerEdit = {
						save: function (data) {
							scope.edit(data);
						},
						close: function () {
							modal.close();
						},
						getCategory: function () {
							return categoryEdit;
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