angular.module("student", [])
	.directive("student", [
		function () {
			return {
				restrict: "E",
				replace: true,
				scope: {},
				link: function (scope) {

				},
				templateUrl: "Scripts/student/student.html"
			}
		}
	]);