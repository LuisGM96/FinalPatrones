using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    public abstract class AbstractGameAttemptFactory {
        public enum GameType { SPACE_SHIP, DRAG_AND_DROP };

        private static SpaceShipAttemptFactory spaceShipFactory = new SpaceShipAttemptFactory();
        private static DragAndDropAttemptFactory dragAndDropFactory = new DragAndDropAttemptFactory();

        public static AbstractGameAttemptFactory getFactory(GameType gameType) {
            switch(gameType) {
                case GameType.SPACE_SHIP:
                    return spaceShipFactory;
                case GameType.DRAG_AND_DROP:
                    return dragAndDropFactory;
            }
            return null;
        }

        public abstract Score createScore(List<object> data);
        public abstract GameAttempt createAttempt(List<object> data);
    }
}
