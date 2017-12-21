using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GPS_Mods
{
    struct coordinates
    {
        public double coord1;
        public double coord2;
    };
    struct GeodesicCoordinates
    {
        public double m_dLatitudeGrad;   /// широта градусы,минуты, секунды
        public double m_dLatitudeMin;
        public double m_dLatitudeSec;
        public double m_dLongtitudeGrad; /// долгота градусы,минуты, секунды
        public double m_dLongtitudeMin;
        public double m_dLongtitudeSec;
        public double m_dLatitude;       /// широта радианы
        public double m_dLongtitude;     /// долгота радианы
    };

    struct _RHT
    {
        double m_dX;  /// координата X
        double m_dY;  /// коордната Y
        double m_dZ;  /// координата Z        
    };

    static class Constants
    {
        public const double Pi = 3.1415926535897932384626433832795;
        public const int SpeedOfLight = 300000; // km per sec.   

    }
    class TransformCoordinates
    {
        /// геодезические координаты
        private GeodesicCoordinates _coord;
        /// плоские прямоугольные координаты в проекции Гаусса-Крюгера
        private double m_dX;
        private double m_dY;

        /// радианы в градусы
        public double RAD_TO_DEGREE(double rad) { return (rad) * (180 / Constants.Pi); }
        /// градусы в радианы
        public double DEGREE_TO_RAD(double dgr) { return (dgr) / (180 / Constants.Pi); }

        /// преобразование из геодезической СК в СК Гаусса-Крюгера
        public void Transform(double lat, double lon)
        {
            _coord.m_dLatitude = lat;
            _coord.m_dLongtitude = lon;
            double d_MinSec;
            _coord.m_dLatitudeGrad = Math.Truncate(RAD_TO_DEGREE(_coord.m_dLatitude));
            d_MinSec = _coord.m_dLatitude - _coord.m_dLatitudeGrad;
            _coord.m_dLatitudeMin = 60 * Math.Truncate(d_MinSec * 60);
            _coord.m_dLatitudeSec = (d_MinSec * 60) - _coord.m_dLatitudeMin;

            _coord.m_dLongtitudeGrad = Math.Truncate(RAD_TO_DEGREE(_coord.m_dLongtitude));
            d_MinSec = _coord.m_dLongtitude - _coord.m_dLongtitudeGrad;
            _coord.m_dLongtitudeMin = 60 * Math.Truncate(d_MinSec * 60);
            _coord.m_dLongtitudeSec = (d_MinSec * 60) - _coord.m_dLongtitudeMin;
            Transform(_coord);
        }

        public void Transform(GeodesicCoordinates coord)
        {
            _coord = coord;
            _coord.m_dLatitude = coord.m_dLatitude
                    = DEGREE_TO_RAD(coord.m_dLatitudeGrad
                                                + coord.m_dLatitudeMin / 60
                                                + coord.m_dLatitudeSec / 3600);
            _coord.m_dLongtitude = coord.m_dLongtitude
                    = DEGREE_TO_RAD(coord.m_dLongtitudeGrad
                                                 + coord.m_dLongtitudeMin / 60
                                                 + coord.m_dLongtitudeSec / 3600);
            /// промежуточная переменная, синус широты
            double d_LatSin = Math.Sin(GetLatitudeRad());

            /// номер шестиградусной зоны в проекции Гаусса-Крюгера
            int n_zone = (6 + Convert.ToInt32(GetLongTitude())) / 6;

            /// расстояние от точки до осевого меридиана шестиградусной зоны
            /// в проекции Гаусса-Крюгера в радианах
            double l_zone = (GetLongTitude() - (3 + 6 * (n_zone - 1))) / (180 / Constants.Pi);

            /// вычисление координат в метрах
            m_dX = 6367558.4968 * GetLatitudeRad()
                    - Math.Sin(2 * GetLatitudeRad())
                    * (16002.8900 + 66.9607 * Math.Pow(d_LatSin, 2) + 0.3515 * Math.Pow(d_LatSin, 4)
                        - Math.Pow(l_zone, 2)
                                * (1594561.25 + 5336.535 * Math.Pow(d_LatSin, 2)
                                    + 26.790 * Math.Pow(d_LatSin, 4) + 0.149 * Math.Pow(d_LatSin, 6)
                                    + Math.Pow(l_zone, 2)
                                    * (672483.4 - 811219.9 * Math.Pow(d_LatSin, 2)
                                         + 5420.0 * Math.Pow(d_LatSin, 4) - 10.6 * Math.Pow(d_LatSin, 6)
                                         + Math.Pow(l_zone, 2)
                                         * (278194 - 830174 * Math.Pow(d_LatSin, 2)
                                             + 572434 * Math.Pow(d_LatSin, 4) - 16010 * Math.Pow(d_LatSin, 6)
                                             + Math.Pow(l_zone, 2)
                                             * (109500 - 574700 * Math.Pow(d_LatSin, 2)
                                                 + 863700 * Math.Pow(d_LatSin, 4) - 398600 * Math.Pow(d_LatSin, 6)
                                                )
                                            )
                                        )
                                   )
                       );
            m_dY = (double)(5 + 10 * n_zone) * Math.Pow(10, 5) + l_zone * Math.Cos(GetLatitudeRad())
                    * (6378245 + 21346.1415 * Math.Pow(d_LatSin, 2) + 107.1590 * Math.Pow(d_LatSin, 4)
                        + 0.5977 * Math.Pow(d_LatSin, 6)
                        + Math.Pow(l_zone, 2)
                        * (1070204.16 - 2136826.66 * Math.Pow(d_LatSin, 2) + 17.98 * Math.Pow(d_LatSin, 4)
                            - 11.99 * Math.Pow(d_LatSin, 6)
                            + Math.Pow(l_zone, 2)
                            * (270806 - 1523417 * Math.Pow(d_LatSin, 2) + 1327645 * Math.Pow(d_LatSin, 4)
                               - 21701 * Math.Pow(d_LatSin, 6)
                               + Math.Pow(l_zone, 2)
                               * (79690 - 866190 * Math.Pow(d_LatSin, 2) + 1730360 * Math.Pow(d_LatSin, 4)
                                   - 945460 * Math.Pow(d_LatSin, 6)
                                  )
                               )
                           )
                       );
        }

        public double GetLatitude()
        {
            return _coord.m_dLatitudeGrad
                           + _coord.m_dLatitudeMin / 60
                           + _coord.m_dLatitudeSec / 3600;
        }

        public double GetLongTitude()
        {
            return _coord.m_dLongtitudeGrad
                         + _coord.m_dLongtitudeMin / 60
                         + _coord.m_dLongtitudeSec / 3600;
        }

        public double GetLatitudeRad()
        {
            return DEGREE_TO_RAD(_coord.m_dLatitudeGrad
                                                    + _coord.m_dLatitudeMin / 60
                                                    + _coord.m_dLatitudeSec / 3600);
        }

        public double GetLongTitudeRad()
        {
            return DEGREE_TO_RAD(_coord.m_dLongtitudeGrad
                                                    + _coord.m_dLongtitudeMin / 60
                                                    + _coord.m_dLongtitudeSec / 3600);
        }

        /// координаты в метрах вещественное число Гаусс-Крюгер
        public double GetX() { return m_dX; }
        public double GetY() { return m_dY; }
    }
}
