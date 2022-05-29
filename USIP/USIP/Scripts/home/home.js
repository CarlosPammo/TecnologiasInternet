angular.module("home", [])
	.directive("home", ["Api", "Authentication", "$uibModal",
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
						template: "<student handler='handler' student='student'></student>"
					};

					function load() {
						api.student.get(
							function (response) {
								scope.students = response.students;
							}
						);
					}

					scope.openEditor = function () {
						modal = $modal.open(config);
					};

					scope.handler = {
						save: function (data) {
							api.student.post(data,
								function (response) {
									load();
									modal.close();
								}
							);
						}
					}

					scope.edit = function (student) {
						scope.student = student;
						api.student.put(student,
							function (response) {
								load();
								modal.close();
							}
						);
					};

					scope.delete = function (student) {
						api.student.delete(student,
							function () {
								load();
							}
						);
					};

					scope.logOut = function () {
						authentication.loggingOff();
					}

					load();
				},
				templateUrl: "Scripts/home/home.html"
			}
		}
	]);