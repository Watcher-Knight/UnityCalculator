using UnityEngine;

namespace Calculator
{
    public static class Vector2Calculator
    {
        public static bool InsideBox(this Vector2 point, Vector2 center, Vector2 size)
        {
            Vector2 hExt = size / 2f;
            Vector2 dif = point - center;

            return Mathf.Abs(dif.x) <= hExt.x && Mathf.Abs(dif.y) <= hExt.y;
        }
    }
}