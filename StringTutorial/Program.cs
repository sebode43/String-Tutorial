using System;

namespace StringTutorial {
    class Program {
        static void Main(string[] args) {
            
            var st1 = new StringTutorialClass();
            var fullname = st1.Fullname();
            Console.WriteLine($"Fullname is {fullname}");
            Console.WriteLine($"Fullname2 is {st1.Fullname2()}");

            var Denise = new StringTutorialClass("Denise", "Bartick");
            Console.WriteLine($"Denise {Denise.Fullname()}");
            Console.WriteLine($"Denise {Denise.Fullname2()}");

            }
        }
    }
