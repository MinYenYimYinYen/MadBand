using MadBand.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MadBand.Application.Members.Queries.GetMemberDetail
{
	public class MemberDetailModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public static Expression<Func<Member, MemberDetailModel>> Projection => member => new MemberDetailModel
		{
			Id = member.MemberID,
			FirstName = member.FirstName,
			LastName = member.LastName
		};

		public static MemberDetailModel Create(Member member)
		{
			return Projection.Compile().Invoke(member);
		}
	}
}
