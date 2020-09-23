using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipocs.objects.Objects
{
  public abstract class PointsMotor
  {
    [SafeForDependencyAnalysis]
    public string TypeName { [Pure] get { return GetType().Name; } }
    public abstract byte MotorTypeId { get; }

    public abstract List<byte> Serialize();
  }
}
