using Blood_Management_System.Data;

namespace Blood_Management_System.Models
{
    public class DonorRepository
    {
        public void addDonor(Donor donor)
        {
            BmsContext bmsContext = new BmsContext();
            bmsContext.Donors.Add(donor);
            bmsContext.SaveChanges();
        }

        public List<Donor> getDonors()
        {
            List<Donor> list = new List<Donor>();
            BmsContext bmsContext = new BmsContext();
            var donors = bmsContext.Donors;
            foreach(var donor in donors)
            {
                list.Add(donor);
            }
            return list;
        }

        public void update(Donor donor)
        {
            Console.WriteLine(donor.Id);
            BmsContext bmsContext = new BmsContext();
            bmsContext.Donors.Update(donor);
            bmsContext.SaveChanges();
        }

        public void delete(int id)
        {
            BmsContext bmsContext = new BmsContext();
            Donor d = new Donor { Id = id };
            bmsContext.Donors.Remove(d);
            bmsContext.SaveChanges();
        }
    }
}
