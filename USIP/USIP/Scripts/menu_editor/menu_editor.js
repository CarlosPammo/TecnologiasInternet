angular.module("menu_editor", [])
	.directive("menuEditor", ["Authentication", "$location",
		function (authentication, $location) {
			return {
				restrict: "E",
				replace: true,
				scope: {},
				link: function (scope) {
					scope.user = authentication.loggedUser.username;

					scope.logOut = function () {
						authentication.loggingOff(function () {
							$location.path("/login");
						});
					}

					scope.changePage = function (root) {
						$location.path(root);
					}
				},
				templateUrl: "Scripts/menu_editor/menu_editor.html"
			}
		}
	]);