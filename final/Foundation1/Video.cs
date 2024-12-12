using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comments)
    {
        _comments.Add(comments);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}
