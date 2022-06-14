namespace IssueObserver.Change
{
    interface IChange
    {
        public int Id { get; set; }
        public string HtmlUrl { get; set; }
    }
}
