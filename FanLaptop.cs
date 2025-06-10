using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300093
{
        class FanLaptop
        {
            public enum State { Quiet, Balanced, Performance, Turbo };
            public enum Trigger { ModeUp, ModeDown, TurboShortcut };
            private State currentState;
            class changeMode
            {
                public State stateAwal;
                public Trigger trigger;
                public State stateAkhir;
                public changeMode(State stateAwal, Trigger trigger, State stateAkhir)
                {
                    this.stateAwal = stateAwal;
                    this.trigger = trigger;
                    this.stateAkhir = stateAkhir;
                }
            }

            private changeMode[] changes = {
        new changeMode( State.Quiet, Trigger.ModeUp, State.Balanced ),
        new changeMode( State.Balanced, Trigger.ModeUp, State.Performance),
        new changeMode( State.Performance, Trigger.ModeUp, State.Turbo),
        new changeMode( State.Turbo, Trigger.ModeDown, State.Performance),
        new changeMode( State.Performance, Trigger.ModeDown, State.Balanced),
        new changeMode( State.Balanced, Trigger.ModeDown, State.Quiet),
        new changeMode( State.Quiet, Trigger.TurboShortcut, State.Turbo),
        new changeMode( State.Balanced, Trigger.TurboShortcut, State.Turbo),
        new changeMode( State.Performance, Trigger.TurboShortcut, State.Turbo),
        new changeMode( State.Turbo, Trigger.TurboShortcut, State.Turbo)
    };

            public State GetNextState(State stateAwal, Trigger trigger)
            {
                for (int i = 0; i < changes.Length; i++)
                {
                    if (changes[i].stateAwal == stateAwal && changes[i].trigger == trigger)
                    {
                        return changes[i].stateAkhir;
                    }
                }
                return stateAwal;
            }

        }
}
