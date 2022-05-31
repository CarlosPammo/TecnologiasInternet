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


				templateUrl: "Scripts/edit_category/edit_category.html"
			}
		}
	]);