using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public class Booster : BasicObject
  {
    public override byte ObjectTypeId { get { return 5; } }

    public byte NumBoosters { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(this.NumBoosters);
    }
  }
}
