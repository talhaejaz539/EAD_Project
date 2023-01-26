using Blood_Management_System.Data;

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

        public void signUp(Member member) { 
            
            BmsContext bmsContext = new BmsContext();
            bmsContext.Members.Add(member);
            bmsContext.SaveChanges();

        }
    }
}
