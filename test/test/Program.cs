//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class MergeNames
//{
//    public static string[] UniqueNames(string[] names1, string[] names2)
//    {
//        var list = new List<string>();
//        list.AddRange(names1.ToList());
//        list.AddRange(names2.ToList());
//        return list.GroupBy(x => x).Select(x => x.First()).ToArray();
//    }

//    public static void Main(string[] args)
//    {
//        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
//        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
//        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
//        Console.ReadKey();
//    }
//}

//using System;

//public class QuadraticEquation
//{
//    public static Tuple<double, double> FindRoots(double a, double b, double c)
//    {
//        var d = b * b - 4 * a * c;
//        if (d == 0)
//        {
//            var x1 = -b / (2.0 * a);
//            return new Tuple<double, double>(x1, x1);

//        }
//        else if (d > 0)
//        {
//            var x1 = (-b + Math.Sqrt(d)) / (2 * a);
//            var x2 = (-b - Math.Sqrt(d)) / (2 * a);
//            return new Tuple<double, double>(x1, x2);
//        }

//        throw new NotImplementedException("Waiting to be implemented.");
//    }

//    public static void Main(string[] args)
//    {
//        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
//        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
//    }
//}

//using System;

//public class Node
//{
//    public int Value { get; set; }

//    public Node Left { get; set; }

//    public Node Right { get; set; }

//    public Node(int value, Node left, Node right)
//    {
//        Value = value;
//        Left = left;
//        Right = right;
//    }
//}

//public class BinarySearchTree
//{
//    public static bool Contains(Node root, int value)
//    {
//        if (root.Value.Equals(value))
//        {
//            return true;
//        }

//        if (root.Value > value && root.Left != null)
//        {
//            return Contains(root.Left, value);
//        }

//        if (root.Value < value && root.Right != null)
//        {
//            return Contains(root.Right, value);
//        }

//        return false;
//    }

//    public static void Main(string[] args)
//    {
//        Node n1 = new Node(1, null, null);
//        Node n3 = new Node(3, null, null);
//        Node n2 = new Node(2, n1, n3);

//        Console.WriteLine(Contains(n2, 3));
//    }
//}

//using System;

//public class Song
//{
//    private string name;
//    public Song NextSong { get; set; }

//    public Song(string name)
//    {
//        this.name = name;
//    }

//    public bool IsRepeatingPlaylist()
//    {
//        var slow = this.NextSong;
//        var fast = slow == null ? null : slow.NextSong;
//        while (fast != null)
//        {
//            if (slow == this || slow == fast)
//                return true;
//            slow = slow.NextSong;
//            fast = fast.NextSong;
//            if (fast != null)
//                fast = fast.NextSong;
//        }
//        return false;
//    }

//    public static void Main(string[] args)
//    {
//        Song first = new Song("Hello");
//        Song second = new Song("Eye of the tiger");

//        first.NextSong = second;
//        second.NextSong = first;

//        Console.WriteLine(first.IsRepeatingPlaylist());
//    }
//}

//using System;
//using System.Collections.Generic;

//public class TextInput
//{
//    protected List<char> _list;

//    public TextInput()
//    {
//        _list = new List<char>();
//    }

//    public virtual void Add(char c)
//    {
//        _list.Add(c);
//    }
//    public string GetValue()
//    {
//        return new string(_list.ToArray()); ;
//    }
//}

//public class NumericInput : TextInput
//{
//    public override void Add(char c)
//    {
//        if (Char.IsNumber(c))
//            _list.Add(c);
//    }
//}

//public class UserInput
//{
//    public static void Main(string[] args)
//    {
//        TextInput input = new NumericInput();
//        input.Add('1');
//        input.Add('a');
//        input.Add('0');
//        Console.WriteLine(input.GetValue());
//    }
//}

//using System;
//using System.Collections.Generic;

//class TwoSum
//{
//    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
//    {
//        HashSet<int> hs = new HashSet<int>();
//        for (int i = 0; i < list.Count; i++)
//        {
//            var needed = sum - list[i];
//            if (hs.Contains(needed))
//            {
//                return Tuple.Create(list.IndexOf(needed), i);
//            }
//            hs.Add(list[i]);
//        }
//        //for (int i = 0; i < list.Count; i++)
//        //{
//        //    var needed = sum - list[i];
//        //    if (list.Contains(needed))
//        //    {
//        //        if(!list.IndexOf(needed).Equals(i))
//        //            return Tuple.Create(list.IndexOf(needed), i);
//        //    }
//        //}
//        return null;
//    }

//    public static void Main(string[] args)
//    {
//        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
//        if (indices != null)
//        {
//            Console.WriteLine(indices.Item1 + " " + indices.Item2);
//        }
//    }
//}

//using System;

//public class Account
//{
//    [Flags]
//    public enum Access
//    {
//        None = 0,
//        Delete = 1,
//        Publish = 2,
//        Submit = 4,
//        Comment = 8,
//        Modify = 16,

//        // combinations
//        Writer = Submit | Modify,
//        Editor = Delete | Publish | Comment,
//        Owner = Writer | Editor
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Xml.Linq;

////[Serializable, XmlRoot("folder")]
////public class Folder
////{
////    [XmlAttribute("name")]
////    public string Name { get; set; }

////    [XmlElement("folder")]
////    public List<Folder> SubFolders { get; set; }

////    public bool StartsWith(string startingString)
////    {
////        return Name.StartsWith(startingString);
////    }

////    public bool StartsWith(char startingChar)
////    {
////        return StartsWith(startingChar.ToString());
////    }
////}

//public class Folders
//{
//    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
//    {
//        //var xmlSerializer = new XmlSerializer(typeof(Folder));
//        //var folders = (Folder)xmlSerializer.Deserialize(new StringReader(xml));
//        //var foldersMatchingCharacter = new List<string>();
//        //if (folders.StartsWith(startingLetter))
//        //{
//        //    foldersMatchingCharacter.Add(folders.Name);
//        //}
//        //foldersMatchingCharacter.AddRange(folders.SubFolders.Where(x => x.StartsWith(startingLetter)).Select(x => x.Name));
//        //foldersMatchingCharacter.AddRange(folders.SubFolders.SelectMany(x => x.SubFolders).Where(x => x.StartsWith(startingLetter)).Select(x => x.Name));
//        //return foldersMatchingCharacter;

//        XDocument doc = XDocument.Parse(xml);
//        var folders = doc.Descendants("folder");
//        return folders
//            .Where(x=>x.Attribute("name").Value.StartsWith(startingLetter.ToString()))
//            .Select(x => x.Attribute("name").Value);
//    }

//    public static void Main(string[] args)
//    {
//        string xml =
//            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
//            "<folder name=\"c\">" +
//                "<folder name=\"program files\">" +
//                    "<folder name=\"uninstall information\" />" +
//                "</folder>" +
//                "<folder name=\"users\" />" +
//            "</folder>";

//        foreach (string name in Folders.FolderNames(xml, 'u'))
//            Console.WriteLine(name);

//        Console.ReadLine();
//    }
//}

//using System;

//public class SortedSearch
//{
//    public static int CountNumbers(int[] sortedArray, int lessThan)
//    {
//        //return sortedArray.Where(x => x < lessThan).Count();
//        int start = 0;
//        int end = sortedArray.Length - 1;
//        int mid = 0;
//        while (start <= end)
//        {
//            mid = (start + end) / 2;
//            if (sortedArray[mid] < lessThan)
//            {
//                if (mid < sortedArray.Length - 1 && sortedArray[mid + 1] < lessThan)
//                {
//                    start = mid + 1;
//                    continue;
//                }
//                else
//                    return mid + 1;
//            }

//            if (sortedArray[mid] >= lessThan)
//            {
//                end = mid - 1;
//            }
//            else
//            {
//                start = mid + 1;
//            }
//        }
//        return 0;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
//    }
//}



//using System;

//class TrainNode
//{
//    public int value;
//    public TrainNode leftTrain;
//    public TrainNode rightTrain;

//    public TrainNode(int value)
//    {
//        this.value = value;
//        this.leftTrain = null;
//        this.rightTrain = null;
//    }
//    public void setRightTrain(TrainNode right)
//    {
//        this.rightTrain = right;
//    }
//    public void setLeftTrain(TrainNode left)
//    {
//        this.leftTrain = left;
//    }
//}

//public class TrainComposition
//{
//    private TrainNode leftMost;
//    private TrainNode rightMost;

//    public TrainComposition()
//    {
//        leftMost = null;
//        rightMost = null;
//    }

//    public void AttachWagonFromLeft(int wagonId)
//    {
//        TrainNode tmp = new TrainNode(wagonId);
//        if (leftMost != null)
//        {
//            //trains in composition
//            leftMost.setLeftTrain(tmp);
//            tmp.setRightTrain(leftMost);
//            leftMost = tmp;
//        }
//        else
//        {
//            leftMost = tmp;
//            rightMost = tmp;
//        }
//    }

//    public void AttachWagonFromRight(int wagonId)
//    {
//        TrainNode tmp = new TrainNode(wagonId);
//        if (rightMost != null)
//        {
//            //trains in composition
//            rightMost.setRightTrain(tmp);
//            tmp.setLeftTrain(rightMost);
//            rightMost = tmp;
//        }
//        else
//        {
//            leftMost = tmp;
//            rightMost = tmp;
//        }
//    }

//    public int DetachWagonFromLeft()
//    {
//        TrainNode tmp;
//        if (leftMost != null)
//        {
//            tmp = leftMost;
//            leftMost = leftMost.rightTrain;
//            int tmpValue = tmp.value;
//            return tmpValue;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public int DetachWagonFromRight()
//    {
//        TrainNode tmp;
//        if (rightMost != null)
//        {
//            tmp = rightMost;
//            rightMost = rightMost.leftTrain;
//            int tmpValue = tmp.value;
//            return tmpValue;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public static void Main(string[] args)
//    {
//        TrainComposition train = new TrainComposition();
//        train.AttachWagonFromLeft(7);
//        train.AttachWagonFromLeft(13);
//        Console.WriteLine(train.DetachWagonFromRight()); // 7 
//        Console.WriteLine(train.DetachWagonFromLeft()); // 13
//    }
//}


//using System.Collections.Generic;
//using System;

//public class AlertService
//{
//    private readonly IAlertDAO storage = new AlertDAO();

//    public AlertService(IAlertDAO a)
//    {
//        storage = a;
//    }

//    public Guid RaiseAlert()
//    {
//        return this.storage.AddAlert(DateTime.Now);
//    }

//    public DateTime GetAlertTime(Guid id)
//    {
//        return this.storage.GetAlert(id);
//    }
//}

//public interface IAlertDAO
//{

//    Guid AddAlert(DateTime time);
//    DateTime GetAlert(Guid id);
//}
//public class AlertDAO : IAlertDAO
//{
//    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

//    public Guid AddAlert(DateTime time)
//    {
//        Guid id = Guid.NewGuid();
//        this.alerts.Add(id, time);
//        return id;
//    }

//    public DateTime GetAlert(Guid id)
//    {
//        return this.alerts[id];
//    }
//}



//using System.Collections.Generic;
//using System;

//public class Account
//{
//    public double Balance { get; private set; }
//    public double OverdraftLimit { get; private set; }

//    public Account(double overdraftLimit)
//    {
//        this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
//        this.Balance = 0;
//    }

//    public bool Deposit(double amount)
//    {
//        if (amount >= 0)
//        {
//            this.Balance += amount;
//            return true;
//        }
//        return false;
//    }

//    public bool Withdraw(double amount)
//    {
//        if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
//        {
//            this.Balance -= amount;
//            return true;
//        }
//        return false;
//    }

//    public static void Main(string[] args)
//    {
//        //1
//        Account account = new Account(20);

//        account.Deposit(10);

//        var b1 = account.Balance; //10

//        //3
//        account = new Account(20);

//        account.Withdraw(10);

//        var b3 = account.Balance; //-10

//        //4
//        account = new Account(0);
//        account.Deposit(20);

//        account.Withdraw(10);

//        var b4 = account.Balance; //10
//    }

//    using System;
//using NUnit.Framework;

//[TestFixture]
//public class Tester
//{
//    private double epsilon = 1e-6;

//    [Test]
//    public void AccountCannotHaveNegativeOverdraftLimit()
//    {
//        Account account = new Account(-20);

//        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
//    }

//    [Test]
//    public void AccountCannotHaveNegativeDepositAndWithdraw()
//    {
//        Account account = new Account(20);

//        var result1 = account.Deposit(-20);
//        var result2 = account.Withdraw(-20);

//        Assert.AreEqual(result1, false);
//        Assert.AreEqual(result2, false);
//    }

//    [Test]
//    public void AccountCannotOverstepItsOverdraftLimit()
//    {
//        Account account = new Account(20);

//        var result = account.Withdraw(200);

//        Assert.AreEqual(result, false);
//    }

//    [Test]
//    public void AccountDepositAndWithdrawCorrectDepositAndWithdraw()
//    {
//        Account account1 = new Account(20);

//        account1.Deposit(10);

//        Assert.AreEqual(10, account1.Balance, epsilon);

//        //2    
//        Account account2 = new Account(20);

//        account2.Withdraw(10);

//        Assert.AreEqual(-10, account2.Balance, epsilon);

//        //3
//        Account account3 = new Account(0);
//        account3.Deposit(20);

//        account3.Withdraw(10);

//        Assert.AreEqual(10, account3.Balance, epsilon);
//    }

//    [Test]
//    public void AccountDepositAndWithdrawWorkCorrect()
//    {
//        Account account = new Account(20);

//        var result1 = account.Deposit(200);
//        Assert.AreEqual(result1, true);

//        var result2 = account.Withdraw(100);
//        Assert.AreEqual(result2, true);
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//public class test
//{




//    public static void Main(string[] args)
//    {
//        var regex = new Regex("(.)\\1+");
//        var input = "aaaaabbbsersdrgdrgddtgdfgfgcfcbccc";

//       // Console.WriteLine(regex.Replace(input, "$1"));



//        var d = new String(input.Select((x, i) => new { x, i })
//            .Where(x => x.i == input.Length - 1 || input[x.i + 1] != x.x)
//            .Select(x => x.x)
//            .ToArray());


//        Console.WriteLine(d);

//        Console.Read();
//    }
//}






//using System;
//using System.Linq;
//using System.Text.RegularExpressions;

//public class Username
//{
//    public static bool Validate(string username)
//    {
//        if (username.Count() < 4)
//            return false;
//        Regex regex = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
//        return regex.IsMatch(username);

//        return true;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Validate("Mike_Standish")); // Valid username
//        Console.WriteLine(Validate("Mike Standish")); // Invalid username
//        Console.Read();
//    }
//}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

//public class ChineseBox
//{
//    private readonly ChineseBox containedBox;

//    public ChineseBox() { }

//    public ChineseBox(ChineseBox containedBox)
//    {
//        this.containedBox = containedBox;
//    }

//    public int NumberOfSmallerBoxes
//    {
//        get
//        {

//            //string.Empty

//            //if (containedBox == null)
//            //{
//            //    return 0;
//            //}
//            //else
//            //{
//            var slow = this.containedBox;
//            var fast = slow == null ? null : slow.containedBox;
//            while (fast != null)
//            {
//                if (slow == this || slow == fast)
//                    return 1;

//                slow = slow.containedBox;
//                fast = fast.containedBox;
//                if (fast != null)
//                    fast = fast.containedBox;
//            }
//            return 0;
//            }
//        }
//    }


//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Xml.Linq;

//public class LogParser
//{
//    public static IEnumerable<int> GetIdsByMessage(string xml, string message)
//    {
//        XDocument doc = XDocument.Parse(xml);
//        var folders = doc.Descendants("entry");

//        return folders
//            .Where(x => x.Value.Contains(message))
//            .Select(x => int.Parse(x.Attribute("id").Value));


//        //return new List<int>();
//    }

//    //.Where(x => x.Attribute("name").Value.Contains(message.ToString()))
//    //        .Select(x => x.Attribute("name").Value).Count();

//    public static void Main(string[] args)
//    {
//        String xml =
//                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
//                "<log>\n" +
//                "    <entry id=\"1\">\n" +
//                "        <message>Application started</message>\n" +
//                "    </entry>\n" +
//                "    <entry id=\"2\">\n" +
//                "        <message>Application ended</message>\n" +
//                "    </entry>\n" +
//                "</log>";

//        foreach (var id in LogParser.GetIdsByMessage(xml, "Application ended"))
//            Console.WriteLine(id);

//        Console.Read();
//    }
//}







//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//public class reg
//{
//    public static void Main(string[] args)
//    {
//        //4 и более символов
//        //буквы цифры _
//        //начинатся с буквы и не заканчиватся на цифры _
//        //var pattern_1 = new Regex(@"[a-zA-Z0-9_]");
//        var pattern_1 = new Regex(@"(^[a-zA-Z]{1}[a-zA-Z0-9]{0,}_[a-zA-Z0-9]{0,}[a-zA-Z]{1,}$)");
//        var items_1 = new List<string>() { 
//            "Mike_Stand",
//            "mike_stand",

//            "MikeStand",
//            "mikestand",

//            "Mike_",
//            "_Mike",

//            "Mi_ke_Stand",
//            "Mike__Stand",
//            "Mike+Stand",
//            "Mike+_Stand",
//            "Mike_+Stand",

//            "1Mike_1Stand",
//            "Mike_1Stand1",  

//            "M_d",
//            "M1_d",
//            "M_1d"
//        };

//        foreach (var item in items_1)
//        {
//            if (pattern_1.IsMatch(item))
//            {
//                Console.WriteLine($"{item} => ok");
//            }
//            else
//            {
//                Console.WriteLine($"{item} => wrong");
//            }
//        }

//        Console.Read();
//    }
//}





