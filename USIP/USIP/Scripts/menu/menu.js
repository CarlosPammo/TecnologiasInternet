angular.module("menu", [])
	.directive("customMenu", ["Api", "Authentication", "$location",
		function (api, authentication, $location) {
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

					function load() {
						api.category.get(
							function (response) {
								scope.categorys = response.categorys;
								categorys = response.categorys;

							}
						);
					}


					scope.changePage = function (root) {
						$location.path(root);
					}


					load();
				},
				templateUrl: "Scripts/menu/menu.html"
			}
		}
	]);