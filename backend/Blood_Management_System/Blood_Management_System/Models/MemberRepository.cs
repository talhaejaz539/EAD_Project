using Blood_Management_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Blood_Management_System.Models
{
    public class MemberRepository
    {
        public Member login(Member m)
        {
            Member ms = null;

            BmsContext bmsContext = new BmsContext();
            bmsContext.Add(m);

            var members = bmsContext.Members.Where(member => member.Email == m.Email);

            foreach(var member in members)
                if (member.Password == m.Password)
                    return member;
            return ms;
        }

        public void signUp(Member member) 
        {
            BmsContext bmsContext = new BmsContext();
            //bmsContext.userId = member.Id;
            bmsContext.Members.Add(member);
            bmsContext.SaveChanges();
        }

        public List<Member> GetMembers()
        {
            List<Member> list = new List<Member>();
            BmsContext bmsContext = new BmsContext();
            var members = bmsContext.Members;
            foreach (var member in members)
                list.Add(member);
            return list;
        }

        public void updateMember(Member member)
        {
            Console.WriteLine(member.Id);
            BmsContext bmsContext = new BmsContext();
            bmsContext.Members.Update(member);
            bmsContext.SaveChanges();
            //var mem = bmsContext.Members.Find(member.Id);
            ////mem = m;
            //if (mem != null)
            //{
            //    bmsContext.Members.Update(member);
            //    bmsContext.SaveChanges();
            //}
        }

        public void delete(int id)
        {
            BmsContext bmsContext = new BmsContext();
            Member m = new Member { Id = id };
            //m.Id = id;
            bmsContext.Members.Remove(m);
            bmsContext.SaveChanges();
        }
    }
}
