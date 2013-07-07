class BugTrackingController {
    public BugTrackingController($scope) {
        $scope.projects = [
            { "name": "Cross-Database Reporting and Charting", "openIssueCount": 15 },
            { "name": "ToolboxWeb", "openIssueCount": 5 }
        ];
    }
}