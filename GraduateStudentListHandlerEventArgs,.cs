using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace laboratorna4
{
    class GraduateStudentListHandlerEventArgs_
    {
        public string nameOfCollectionOfOccuredEvent {get; set;}
        public string typeOfChangesInTheCollection { get; set; }
        public int numberOfElementThatWasChangedOrAdded { get; set; }
        public GraduateStudentListHandlerEventArgs_()
        {
            nameOfCollectionOfOccuredEvent = "default";
            typeOfChangesInTheCollection = "default";
            numberOfElementThatWasChangedOrAdded = 0;
        }
        public GraduateStudentListHandlerEventArgs_(string name, string type, int number)
        {
            nameOfCollectionOfOccuredEvent = name;
            typeOfChangesInTheCollection = type;
            numberOfElementThatWasChangedOrAdded = number;
        }
        override public string ToString()
        {
            return ($"\n Name of the collection: {nameOfCollectionOfOccuredEvent}\n Type of changes: {typeOfChangesInTheCollection}\n" +
                $" Number of the element that was changed or added: {numberOfElementThatWasChangedOrAdded}\n");
        }
    }
}
