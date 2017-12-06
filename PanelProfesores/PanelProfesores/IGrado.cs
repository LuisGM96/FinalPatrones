using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public abstract class IGrado
    {
        public abstract void setNext(IGrado g);
        public abstract IGrado getNext();
        public abstract string calificar(float grado);
        protected IGrado Next;
    }
    public class Basico : IGrado
    {
        public override string calificar(float grado)
        {
            if (grado < 5)
                return "Basico";
            else
                return Next.calificar(grado);

        }

        public override IGrado getNext()
        {
            return Next;
        }

        public override void setNext(IGrado g)
        {
            Next = g;
        }
    }
    public class Medio : IGrado
    {
        public override string calificar(float grado)
        {
            if (grado < 8 && grado > 4.9)
                return "Medio";
            else
                return Next.calificar(grado);

        }

        public override IGrado getNext()
        {
            return Next;
        }

        public override void setNext(IGrado g)
        {
            Next = g;
        }
    }
    public class Avanzado : IGrado
    {
        public override string calificar(float grado)
        {
            if (grado > 7.9)
                return "Avanzado";
            else
                return Next.calificar(grado);

        }

        public override IGrado getNext()
        {
            return Next;
        }

        public override void setNext(IGrado g)
        {
            Next = g;
        }
    }
    public class Evaluador : IGrado
    {
        public override string calificar(float grado)
        {
            Basico basico = new Basico();
            setNext(basico);
            Medio medio = new Medio();
            basico.setNext(medio);
            Avanzado av = new Avanzado();
            medio.setNext(av);
            return Next.calificar(grado);
        }

        public override IGrado getNext()
        {
            return Next;
        }

        public override void setNext(IGrado g)
        {
            Next = g;
        }
    }
}
