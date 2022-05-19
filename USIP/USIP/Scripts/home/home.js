﻿angular.module("home", [])
	.directive("home", ["Api", "$uibModal",
		function (api, $modal) {
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
								}, function () {
									alert("error del servidor");
								}
							);
						}
					}

					scope.edit = function (student) {
						scope.student = student;
						modal = $modal.open(config);
					};

					scope.delete = function(student) {
					};

					load();
				},
				templateUrl: "Scripts/home/home.html"
			}
		}
	]);