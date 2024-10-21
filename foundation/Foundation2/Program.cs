/* Please Pardon Me */
/* I don't know why, but my foundation1 program gives me this error "Foundation1.csproj' does not support debugging. No launchable target found." whenever I try to run. Hence I decided to work both foundation 1 and foundation 2 in the same area. I hope this helps. Thank you for your consideration.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        List<Video> video = new List<Video>();

        // For video 1
        Video vid1 = new Video();
        vid1._title = "Sport Cars";
        vid1._author = "Sport 1";
        vid1._length = 2;

        string v1C1 = "Evans Green/evg11/The car is nice."; // comments
        string[] commentRef = v1C1.Split("/");
        Comment comment1 = new Comment();
        comment1._name = commentRef[0];
        comment1._handle = commentRef[1];
        comment1._text = commentRef[2];
        vid1.AddComment(comment1); // title,Author,length in minutes
        string v1C2 = "Smith Ray/sm181/Love it looks."; // comments
        commentRef = v1C2.Split("/");
        Comment comment2 = new Comment();
        comment2._name = commentRef[0];
        comment2._handle = commentRef[1];
        comment2._text = commentRef[2];
        vid1.AddComment(comment2); // title,Author,length in minutes
        string v1C3 = "Cole Palmer/cp004/Check the speed man."; // comments
        commentRef = v1C3.Split("/");
        Comment comment3 = new Comment();
        comment3._name = commentRef[0];
        comment3._handle = commentRef[1];
        comment3._text = commentRef[2];
        vid1.AddComment(comment3); // title,Author,length in minutes
        string v1C4 = "Lamie Yamal/lya98/The tyres are huge!"; // comments
        commentRef = v1C4.Split("/");
        Comment comment4 = new Comment();
        comment4._name = commentRef[0];
        comment4._handle = commentRef[1];
        comment4._text = commentRef[2];
        vid1.AddComment(comment1); // title,Author,length in minutes
        video.Add(vid1);
        
        // For video 2
        Video vid2 = new Video();
        vid2._title = "Motor Cycle";
        vid2._author = "Sport 2";
        vid2._length = 15;
        string v2C1 = "Evans Green/evg11/The car is nice."; // comments
        commentRef = v2C1.Split("/");
        Comment comment5 = new Comment();
        comment5._name = commentRef[0];
        comment5._handle = commentRef[1];
        comment5._text = commentRef[2];
        vid2.AddComment(comment5); // title,Author,length in minutes
        string v2C2 = "Smith Ray/sm181/Love it looks."; // comments
        commentRef = v2C2.Split("/");
        Comment comment6 = new Comment();
        comment6._name = commentRef[0];
        comment6._handle = commentRef[1];
        comment6._text = commentRef[2];
        vid2.AddComment(comment6); // title,Author,length in minutes
        string v2C3 = "Cole Palmer/cp004/Check the speed man."; // comments
        commentRef = v2C3.Split("/");
        Comment comment7 = new Comment();
        comment7._name = commentRef[0];
        comment7._handle = commentRef[1];
        comment7._text = commentRef[2];
        vid2.AddComment(comment7); // title,Author,length in minutes
        string v2C4 = "Lamie Yamal/lya98/The tyres are huge!"; // comments
        commentRef = v2C4.Split("/");
        Comment comment8 = new Comment();
        comment8._name = commentRef[0];
        comment8._handle = commentRef[1];
        comment8._text = commentRef[2];
        vid2.AddComment(comment8); // title,Author,length in minutes
        video.Add(vid2);
        
        // For video 3
        Video vid3 = new Video();
        vid3._title = "Fighter Jet";
        vid3._author = "F3 Sports";
        vid3._length = 13;
        string v3C1 = "Evans Green/evg11/The car is nice."; // comments
        commentRef = v3C1.Split("/");
        Comment comment9 = new Comment();
        comment9._name = commentRef[0];
        comment9._handle = commentRef[1];
        comment9._text = commentRef[2];
        vid3.AddComment(comment9); // title,Author,length in minutes
        string v3C2 = "Smith Ray/sm181/Love it looks."; // comments
        commentRef = v3C2.Split("/");
        Comment comment10 = new Comment();
        comment10._name = commentRef[0];
        comment10._handle = commentRef[1];
        comment10._text = commentRef[2];
        vid3.AddComment(comment10); // title,Author,length in minutes
        string v3C3 = "Cole Palmer/cp004/Check the speed man."; // comments
        commentRef = v3C3.Split("/");
        Comment comment11 = new Comment();
        comment11._name = commentRef[0];
        comment11._handle = commentRef[1];
        comment11._text = commentRef[2];
        vid3.AddComment(comment11); // title,Author,length in minutes
        string v3C4 = "Lamie Yamal/lya98/The tyres are huge!"; // comments
        commentRef = v3C4.Split("/");
        Comment comment12 = new Comment();
        comment12._name = commentRef[0];
        comment12._handle = commentRef[1];
        comment12._text = commentRef[2];
        vid3.AddComment(comment12); // title,Author,length in minutes
        video.Add(vid3);
        
        foreach(Video item in video)
        {
            Console.WriteLine("");
            Console.WriteLine(item.GetDisplayText());
            Console.WriteLine("\nName           Handle          Comment");
            foreach(Comment i in item._commentList)
            {
                Console.WriteLine(i.GetDisplayText());
            }
        }
    }
}