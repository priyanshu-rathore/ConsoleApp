
using System;

namespace protectedAccessModifier
{

    class X
    {

        // Member x declared
        // as protected
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    // class Y inherits the
    // class X
    class Y : X
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }

   
}
