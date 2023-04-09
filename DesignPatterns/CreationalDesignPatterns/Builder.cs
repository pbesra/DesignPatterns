namespace DesignPatterns.CreationalDesignPatterns
{
    public class Builder
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Salary { get; set; }
        public string IsActive { get; set; }
        public bool HasWhere { get; set; }
        public List<string> QueryList = new List<string>();

        public Builder WithID(int id)
        {
            ID = $"and ID={id}";
            QueryList.Add(ID);
            return this;
        }

        public Builder OrWithID(int id)
        {
            ID = $"or ID={id}";
            QueryList.Add(ID);
            return this;
        }

        public Builder WithBracket(string bracket)
        {
            QueryList.Add(bracket);
            return this;
        }

        public Builder WithUserName(string userName)
        {
            UserName = $"UserName={userName}";
            QueryList.Add(UserName);
            return this;
        }

        public Builder OrWithUserName(string userName)
        {
            UserName = $"Or UserName={userName}";
            QueryList.Add(UserName);
            return this;
        }

        public Builder WithEmail(string email)
        {
            Email = $"Email={email}";
            QueryList.Add(Email);
            return this;
        }

        public Builder OrWithEmail(string email)
        {
            Email = $"or Email={email}";
            QueryList.Add(Email);
            return this;
        }

        public Builder WithIsActive(bool isActive)
        {
            IsActive = $"and IsActive={isActive}";
            QueryList.Add(IsActive);
            return this;
        }

        public Builder OrWithIsActive(bool isActive)
        {
            IsActive = $"or IsActive={isActive}";
            QueryList.Add(IsActive);
            return this;
        }
        
        public Builder WithJoinTable1AndTable2(string joinType, string table1, string key1, string table2, string key2)
        {
            QueryList.Add($" {joinType} {table1} on {table1}.{key1}={table2}.{key2}");
            return this;
        }
        public Builder WithLeftJoinTable1AndTable2(string table1, string key1, string table2, string key2)
        {
            QueryList.Add($" left join {table1} on {table1}.{key1}={table2}.{key2}");
            return this;
        }
        public Builder WithInnerJoinTable1AndTable2(string table1, string key1, string table2, string key2)
        {
            QueryList.Add($" join {table1} on {table1}.{key1}={table2}.{key2}");
            return this;
        }
        public Builder WithFullJoinTable1AndTable2(string table1, string key1, string table2, string key2)
        {
            QueryList.Add($" full join {table1} on {table1}.{key1}={table2}.{key2}");
            return this;
        }


        public Builder SetWhere(bool where = false)
        {
            HasWhere = where;
            return this;
        }

        public Person GetPersonQuery()
        {
            return new Person(this);
        }
        

        public string ToString()
        {
            return string.Join(' ', QueryList);
        }

        public class Person
        {
            public int ID { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Code { get; set; }
            public string Address { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int Salary { get; set; }
            public bool IsActive { get; set; }
            public bool HasWhere { get; set; }
            public string QueryString { get; set; }

            public string ToString()
            {
                return QueryString;
            }

            public Person(Builder builder)
            {
                QueryString = "";
                if (!builder.HasWhere)
                {
                    QueryString = "Select * from Person";
                }
                else
                {
                    QueryString = $"Select * from Person Where {builder.ToString()}";
                }
            }
        }
    }
}