using System.Collections.Generic;

namespace Hagwartz;

public class availableCode
{
    private List<long> availableCodeList = new List<long>();

    public List<long> AvailableCodeList
    {
        get => availableCodeList;
        set => availableCodeList = value;
    }

    public availableCode()
    {
        AvailableCodeList = null;
    }
}