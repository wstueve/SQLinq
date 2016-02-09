//Copyright (c) Chris Pietschmann 2013 (http://pietschsoft.com)
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://sqlinq.codeplex.com/license

using System;

namespace SQLinq.Dapper.Test
{
    public class IdentityTest_Int : IIdentityTest_Int
    {
        [SQLinqColumn(update: false, insert: false)]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
