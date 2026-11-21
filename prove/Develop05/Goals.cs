class Goals
{
    private List<BaseGoal> _goals;
    private string _fileName;
    private int _totalScore;
    public Goals(string fileName, int totalScore)
    {
        _goals = new List<BaseGoal>();
        _fileName = fileName;
        _totalScore = totalScore;
        
    }
}