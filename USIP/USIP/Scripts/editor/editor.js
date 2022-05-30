angular.module("editor", [])
	.directive("editor", [
		function () {
			return {
				restrict: "E",
				replace: true,
				scope: {
					handler: "=",
					student: "="
				},
				templateUrl: "Scripts/editor/editor.html"
			}
		}
	]);