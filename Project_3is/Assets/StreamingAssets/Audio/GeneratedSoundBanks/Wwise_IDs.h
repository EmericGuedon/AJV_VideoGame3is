/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID FOOTSTEP_CROWM = 3276437528U;
        static const AkUniqueID FOOTSTEP_MOB = 1920073040U;
        static const AkUniqueID FOOTSTEP_WP = 750617883U;
        static const AkUniqueID PLAY_AMB_BLIZZARD = 761535791U;
        static const AkUniqueID PLAY_AMB_CAVE = 2314402090U;
        static const AkUniqueID PLAYSTART_AMB_BLIZZARD = 3040107861U;
        static const AkUniqueID PLAYSTART_CAVE = 3398993223U;
        static const AkUniqueID RFX_BRIDGE = 2958646009U;
        static const AkUniqueID RFX_CAMPFIRE = 3905897693U;
        static const AkUniqueID SHIELD_MAIN = 1013147606U;
        static const AkUniqueID STOP_AMB_BLIZZARD = 1610211621U;
        static const AkUniqueID STOP_AMB_CAVE = 1551221296U;
        static const AkUniqueID SWORD_MAIN = 1101775796U;
        static const AkUniqueID VOICE_MOB = 656988382U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace SWORD_MATERIALS
        {
            static const AkUniqueID GROUP = 3722118999U;

            namespace STATE
            {
                static const AkUniqueID BLOOD_HARD = 2593438961U;
                static const AkUniqueID BLOOD_SOFT = 2090617658U;
                static const AkUniqueID DRY = 630539344U;
                static const AkUniqueID METAL = 2473969246U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace SWORD_MATERIALS

    } // namespace STATES

    namespace SWITCHES
    {
        namespace CROWM_MOOVING
        {
            static const AkUniqueID GROUP = 486177989U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace CROWM_MOOVING

        namespace FOOTSTEP_MATERIALS
        {
            static const AkUniqueID GROUP = 215506544U;

            namespace SWITCH
            {
                static const AkUniqueID SNOW = 787898836U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WOOD = 2058049674U;
            } // namespace SWITCH
        } // namespace FOOTSTEP_MATERIALS

        namespace WP_MOOVING
        {
            static const AkUniqueID GROUP = 1728246464U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace WP_MOOVING

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID RTPC_AMB_DUNGEON = 2829310242U;
        static const AkUniqueID RTPC_BRIDGE = 1903539408U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID SOUNDBANK = 1661994096U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID REVERB_CAVE = 323187407U;
        static const AkUniqueID REVERB_DUNGEON = 892458534U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
