using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IATK;

public class PosScaleUtil 
{


    public static float[] GetMaxAndMinValues(DataSource dataSource, string dimension)
    {
        
            float min = dataSource[dimension].MetaData.minValue;
            float max = dataSource[dimension].MetaData.maxValue;

            return new float[2] { min, max };
 
    }

    public static float FindScalingFactor(float minValue, float maxValue)
    {
        float scale = maxValue - minValue;

        return scale;
    }




}
