angular.module("rectory", [])
    .directive("rectory", ["Authentication", "$location",
        function (authentication, $location) {
            return {
                restrict: "E",
                replace: true,
                scope: {},
                link: function (scope) {
                    
                },
                templateUrl: "Scripts/rectory/rectory.html"
            }
        }
    ]);