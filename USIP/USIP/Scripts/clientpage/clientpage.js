

angular.module("clientpage", [])
    .directive("clientpage", [
        function () {
            return {
                restrict: "E",
                replace: true,
                scope: {}
                link: function (scope) {
                    
                }
                templateUrl: "Scripts/clientpage/clientpage.html"
            };
        }