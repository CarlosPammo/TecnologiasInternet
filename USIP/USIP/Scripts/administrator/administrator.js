angular.module("administrator", [])
    .directive("administrator", ["Api", "Authentication", "$uibModal",
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
                        template: "<user handler='handler' user='user'></user>"
                    };

                    function load() {
                        api.user.get(
                            function (response) {
                                scope.user = response.user;

                            }
                        );
                    }

                    scope.openEditor = function () {
                        modal = $modal.open(config);
                    };

                    scope.handler = {
                        save: function (data) {
                            api.user.post(data,
                                function (response) {
                                    load();
                                    modal.close();
                                }
                            );
                        }
                    }

                    scope.edit = function (user) {
                        scope.user = user;
                        api.user.put(user,
                            function (response) {
                                load();
                                modal.close();
                            }
                        );
                    };

                    scope.delete = function (user) {
                        api.user.delete(User,
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
                templateUrl: "Scripts/administrator/administrator.html"
            }
        }
    ]);