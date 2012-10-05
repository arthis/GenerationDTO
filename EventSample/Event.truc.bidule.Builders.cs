



using System;
using System.Diagnostics.Contracts;
//using CommonDomain.Core.Super.Messaging.ValueObjects;


namespace EventNameSpace
{


	public class doneThatBuilder //: IEventBuilder<SchedulazioneAmbAddedToScenario>
	{
	 
		private string  _property1ssssssssdsdsdsds ; 
		private string  _property2 ;
		public doneThatBuilder ForProperty1ssssssssdsdsdsds(string property1ssssssssdsdsdsds) 
		{
			_property1ssssssssdsdsdsds = property1ssssssssdsdsdsds;
			return this;
		}
	
		public doneThatBuilder ForProperty2(string property2) 
		{
			_property2 = property2;
			return this;
		}
	
		public doneThat Build(Guid id, long version)
		{
			return Build(id, Guid.NewGuid(), version);
		}

		public doneThat Build(Guid id, Guid commitId, long version)
        {
            return new doneThat(id, commitId, version, _property1ssssssssdsdsdsds, _property2);
		 }
        
	
	}

	public class doneThatAlsoBuilder //: IEventBuilder<SchedulazioneAmbAddedToScenario>
	{
	 
		private string  _property1bis ; 
		private string  _property2bis ;
		public doneThatAlsoBuilder ForProperty1bis(string property1bis) 
		{
			_property1bis = property1bis;
			return this;
		}
	
		public doneThatAlsoBuilder ForProperty2bis(string property2bis) 
		{
			_property2bis = property2bis;
			return this;
		}
	
		public doneThatAlso Build(Guid id, long version)
		{
			return Build(id, Guid.NewGuid(), version);
		}

		public doneThatAlso Build(Guid id, Guid commitId, long version)
        {
            return new doneThatAlso(id, commitId, version, _property1bis, _property2bis);
		 }
        
	
	}

	public class whatabouthisoneBuilder //: IEventBuilder<SchedulazioneAmbAddedToScenario>
	{
	 
		private string  _property1bis ; 
		private string  _property2bis ;
		public whatabouthisoneBuilder ForProperty1bis(string property1bis) 
		{
			_property1bis = property1bis;
			return this;
		}
	
		public whatabouthisoneBuilder ForProperty2bis(string property2bis) 
		{
			_property2bis = property2bis;
			return this;
		}
	
		public whatabouthisone Build(Guid id, long version)
		{
			return Build(id, Guid.NewGuid(), version);
		}

		public whatabouthisone Build(Guid id, Guid commitId, long version)
        {
            return new whatabouthisone(id, commitId, version, _property1bis, _property2bis);
		 }
        
	
	}
}
