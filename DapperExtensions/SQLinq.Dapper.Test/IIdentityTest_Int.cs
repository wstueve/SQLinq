//Copyright (c) WDS IT (http://wds-it.com)
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://sqlinq.codeplex.com/license

namespace SQLinq.Dapper.Test
{
    [SQLinqTable("IdentityTest_Int")]
    public interface IIdentityTest_Int
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
