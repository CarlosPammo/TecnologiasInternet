angular.module("edit_category", [])
	.directive("editCategory", [
		function () {
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					category: "=",
					close: "="
				},
				link: function (scope) {
					scope.getCategory = function () {
						let categoryEdit = scope.handler.getCategory();
						scope.category = categoryEdit;
					}
					scope.getCategory();
				},

				

				templateUrl: "Scripts/edit_category/edit_category.html"
			}
		}
	]);