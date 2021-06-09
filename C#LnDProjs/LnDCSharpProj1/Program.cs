using System;

namespace LnDCSharpProj1
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ////ToDo
            //var ToDo = new ToDoClass();
            //// Control Flow exercises 1
            //var case1 = new InputNumber();
            //var case2 = new LargerNumber();
            //var case3 = new PortraitOrLandscape();
            //var case4 = new SpeedCamera();

            //// My own interest / for fun
            //var case5 = new RandomStringGenerator();
            ////DisplayClass
            ////TextWrap

            //// Control Flow exercises 2
            //var case6 = new Remainder();
            //// Arrays and Lists 

            ////

            //// String exercises
            ////var case xx = new xx;
            //string currentValidRange = "1 - 7";
            //Console.WriteLine("Pick and program to run using number keys. Valid numbers range {0}. Press ESC to stop", currentValidRange);
            //string key;
            ////while (Console.ReadKey(true).Key != ConsoleKey.Escape)  // while ((key = Console.ReadKey().KeyChar.ToString()) != "3")
            //string escapeKey = ConsoleKey.Escape.ToString();
            //key = Console.ReadKey().KeyChar.ToString();
            //while ((key = Console.ReadKey().KeyChar.ToString()) != "27") // needs refinement 
            //{
            //    //int keyValue;
            //    //int.TryParse(key, out keyValue);
            //    //Stopwatch.runStopWatch(keyValue);

            //    int keyValue;
            //    int.TryParse(key, out keyValue);
            //    switch (keyValue)
            //    {
            //        case 1:
            //            // ToDo
            //            ToDo.ShowMeToDoText();
            //            break;
            //        case 2:
            //            // Control Flow exercises
            //            case1.GiveNumber();
            //            break;
            //        case 3:
            //            case2.DisplayLargerNum();
            //            break;
            //        case 4:
            //            case3.isPortrait();
            //            break;
            //        case 5:
            //            case4.IsSpeeding();
            //            break;
            //        case 6:
            //            // My own interest / for fun exercises
            //            case5.GenerateRandomString();
            //            break;
            //        case 7:
            //            // Control Flow exercises 2
            //            case6.isDivisibleBy3();
            //            break;
            //        //additional cases needed here 

            //        // Arrays and Lists

            //        // String exercises
            //        case 8:
            //            //Intermediate course exercises

            //            //Classes 1
            //            var Stopwatch = new StopWatch();
            //            string localKey;
            //            Console.WriteLine("Please hit '1' key to start or '2' key to stop. Press '3' to exit.");
            //            while ((localKey = Console.ReadKey().KeyChar.ToString()) != "3")
            //            {
            //                //int keyValue;
            //                //int.TryParse(key, out keyValue);
            //                //Stopwatch.runStopWatch(keyValue);

            //                int localKeyValue;
            //                int.TryParse(key, out localKeyValue);
            //                Stopwatch.Runner(localKeyValue);
            //            }
            //            break;
            //        case 9:
            //            var stackOverflowPost = new StackOverflowPost();
            //            stackOverflowPost.CreatePost();
            //            stackOverflowPost.DisplayPost();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Upvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.Downvote();
            //            stackOverflowPost.DisplayPost();
            //            break;

            //    }

            //Stack stack = new Stack();
            //    stack.Push(1);
            //    stack.Push("2");
            //    stack.Push('3');
            //    stack.Push(4);
            //    stack.Push(5);
            //stack.printStack();
            //    stack.Pop();
            //stack.printStack();
            //stack.Clear();
            //stack.printStack();
            //}
            var stack = new Stack(); 
            stack.Push(1); 
            stack.Push(2); 
            stack.Push(3); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
        }
    }
}
