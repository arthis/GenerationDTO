


using System;
using System.Diagnostics.Contracts;


namespace EventNameSpace
{


	public class doneThat //:Message, IEvent
	{
	 
		public string Property1ssssssssdsdsdsds { get; set;} 
		public string Property2 { get; set;}

		public doneThat ()
		{
			//for serialisation
		}	     

		public doneThat(Guid id, Guid commitId, long version,string property1ssssssssdsdsdsds,string property2)
		   //: base(id,commitId,version)
		{
			Contract.Requires(!string.IsNullOrEmpty(property2));

			Property1ssssssssdsdsdsds = property1ssssssssdsdsdsds ;
			Property2 = property2 ;
		}
			//public override string ToDescription()
		//{
		//	return string.Format(" description done that", Id);
		//}
		
		public bool Equals(doneThat other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other)  	 && Equals(other.Property1ssssssssdsdsdsds, Property1ssssssssdsdsdsds)  	 && Equals(other.Property2, Property2) ; 
		}

		public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as doneThat);
        }

		public override int GetHashCode()
        {
            unchecked
            {
				int result = base.GetHashCode();
				result = (result*397) ^ (Property1ssssssssdsdsdsds != null ? Property1ssssssssdsdsdsds.GetHashCode() : 0);
				result = (result*397) ^ (Property2 != null ? Property2.GetHashCode() : 0);
				return result;
            }
        }
	}

	public class doneThatAlso //:Message, IEvent
	{
	 
		public string Property1bis { get; set;} 
		public string Property2bis { get; set;}

		public doneThatAlso ()
		{
			//for serialisation
		}	     

		public doneThatAlso(Guid id, Guid commitId, long version,string property1bis,string property2bis)
		   //: base(id,commitId,version)
		{
					Property1bis = property1bis ;
			Property2bis = property2bis ;
		}
	
		public bool Equals(doneThatAlso other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other)  	 && Equals(other.Property1bis, Property1bis)  	 && Equals(other.Property2bis, Property2bis) ; 
		}

		public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as doneThatAlso);
        }

		public override int GetHashCode()
        {
            unchecked
            {
				int result = base.GetHashCode();
				result = (result*397) ^ (Property1bis != null ? Property1bis.GetHashCode() : 0);
				result = (result*397) ^ (Property2bis != null ? Property2bis.GetHashCode() : 0);
				return result;
            }
        }
	}

	public class whatabouthisone //:Message, IEvent
	{
	 
		public string Property1bis { get; set;} 
		public string Property2bis { get; set;}

		public whatabouthisone ()
		{
			//for serialisation
		}	     

		public whatabouthisone(Guid id, Guid commitId, long version,string property1bis,string property2bis)
		   //: base(id,commitId,version)
		{
					Property1bis = property1bis ;
			Property2bis = property2bis ;
		}
	
		public bool Equals(whatabouthisone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other)  	 && Equals(other.Property1bis, Property1bis)  	 && Equals(other.Property2bis, Property2bis) ; 
		}

		public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as whatabouthisone);
        }

		public override int GetHashCode()
        {
            unchecked
            {
				int result = base.GetHashCode();
				result = (result*397) ^ (Property1bis != null ? Property1bis.GetHashCode() : 0);
				result = (result*397) ^ (Property2bis != null ? Property2bis.GetHashCode() : 0);
				return result;
            }
        }
	}
}
