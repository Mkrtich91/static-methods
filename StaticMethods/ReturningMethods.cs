namespace StaticMethods
{
    public static class ReturningMethods
    {
        public static bool ReturnBool()
        {
            return true;
        }

        public static byte ReturnByte()
        {
            return 0xAB;
        }

        public static char ReturnChar()
        {
            return 'A';
        }

        public static decimal ReturnDecimal()
        {
            return -123456789.987654321m;
        }

        public static double ReturnDouble()
        {
            return -9876.54321;
        }

        public static float ReturnFloat()
        {
            return 1234.567f;
        }

        public static int ReturnInt()
        {
            return -1234567;
        }

        public static long ReturnLong()
        {
            return -987654321L;
        }

        public static string ReturnString()
        {
            return "Hello, world!";
        }

        public static uint ReturnUnsignedInt()
        {
            return 1234567u;
        }

        public static ulong ReturnUnsignedLong()
        {
            return 987654321uL;
        }
    }
}
