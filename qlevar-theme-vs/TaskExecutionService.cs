using System;

namespace YellowFox.SharedLibrary.Extensions {

    public static class IntegerExtensions {

        public static TimeSpan Day(this int value) {
            return Days(value);
        }

        public static TimeSpan Days(this int value) {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Hour(this int value) {
            return Hours(value);
        }

        public static TimeSpan Hours(this int value) {
            return TimeSpan.FromHours(value);
        }

        public static int Hundred(this int value) {
            return value * 100;
        }

        public static int Million(this int value) {
            return Millions(value);
        }

        public static int Millions(this int value) {
            return value * 1000000;
        }

        public static TimeSpan Millisecond(this int value) {
            return Milliseconds(value);
        }

        public static TimeSpan Milliseconds(this int value) {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Minute(this int value) {
            return Minutes(value);
        }

        public static TimeSpan Minutes(this int value) {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Second(this int value) {
            return Seconds(value);
        }

        public static TimeSpan Seconds(this int value) {
            return TimeSpan.FromSeconds(value);
        }

        public static int Thousend(this int value) {
            return value * 1000;
        }

        public static TimeSpan Tick(this int value) {
            return Ticks(value);
        }

        public static TimeSpan Ticks(this int value) {
            return TimeSpan.FromTicks(value);
        }

        public static TimeSpan Week(this int value) {
            return value.Weeks();
        }

        public static TimeSpan Weeks(this int value) {
            return (value * 7).Days();
        }

        public static int CountDigits(this int value) {
            if (value == 0) {
                return 1;
            }
            return (int) Math.Floor(Math.Log10(value) + 1);
        }

    }

}
