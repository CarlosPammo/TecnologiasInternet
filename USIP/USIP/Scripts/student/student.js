angular.module("student", [])
    .directive("student", ["Api", "Authentication", "$uibModal",
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
                                scope.student = response.student;
                            }
                        );
                    }

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

                    load();
                },
                templateUrl: "Scripts/student/student.html"
            }
        }
    ]);