using System;
using System.Collections.Generic;
using System.Text;

namespace StringTutorial {
    class StringTutorialClass {

        public string Firstname;
        public string Lastname;

        public StringTutorialClass() {
            Firstname = "Sarah";
            Lastname = "Bode";
        }

        public StringTutorialClass(string firstname, string lastname) {
            Firstname = firstname;
            Lastname = lastname;
            }

        public string Fullname() {
            //var Firstname = "Sarah";
            //var Lastname = "Bode";
            var fullname = $"{Lastname}, {Firstname}";
            return fullname;
        }

        public string Fullname2() {
            //var Firstname = "Sarah";
            //var Lastname = "Bode";

            var fullname = $"{Firstname} {Lastname}";
            return fullname;
        }
    }
}
