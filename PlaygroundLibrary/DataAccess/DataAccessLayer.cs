using PlaygroundLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundLibrary.DataAccess
{
    public class DataAccessLayer
    {
        public List<PersonModel> GetPeople()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel(GetMaxId(output), "Daenerys", "Targaryen"));
            output.Add(new PersonModel(GetMaxId(output), "Jon", "Snow"));
            output.Add(new PersonModel(GetMaxId(output), "Tyrion", "Lannister"));
            output.Add(new PersonModel(GetMaxId(output), "Rob", "Stark"));

            return output;
        }

        private int GetMaxId(List<PersonModel> people)
        {
            int output = 0;

            if (people.Count != 0)
            {
                output = people.Max(x => x.Id);
            }
            return output + 1;
        }
    }
}
