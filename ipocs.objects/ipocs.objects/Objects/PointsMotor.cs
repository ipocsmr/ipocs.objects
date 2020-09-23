using PostSharp.Patterns.Model;
using System.Collections.Generic;

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
