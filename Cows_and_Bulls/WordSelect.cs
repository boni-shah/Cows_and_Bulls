using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cows_and_Bulls
{
    class WordSelect
    {
        

        public static string GenerateWord(char M)
        {
            string TheWord = "";

            if (M == 'E')
                TheWord = GenerateEasyWord();
            else if (M == 'M')
                TheWord = GenerateMediumWord();
            else if (M == 'D')
                TheWord = GenerateDifficultWord();

            return TheWord;
        }
        protected static string GenerateEasyWord()
        {
            Random r = new Random();

            string EasyList = "able,aced,aces,ache,acid,acre,acts,aged,ages,ahem,aids,ails,aims,airs,ales,alms,alps,amen,amid,amps,ands,anew,ante,";
            EasyList += "anti,ants,aped,apes,arid,arms,army,arts,atom,atop,aunt,awed,awes,axes,back,bade,bags,bail,bait,bake,bald,bale,balm,band,bang,";
            EasyList += "bank,bans,bark,barn,bars,base,bash,bath,bats,bead,beak,beam,bean,bear,beat,beds,begs,belt,bend,bent,best,bets,bids,bike,bind,";
            EasyList += "bins,bird,bite,blew,blow,blue,blur,boat,body,boil,bold,bolt,bond,bone,bore,born,bots,bowl,bows,brat,bred,buds,bugs,bulk,bump,";
            EasyList += "buns,burp,bush,buys,byes,cabs,cage,cake,calm,came,camp,card,care,cars,cart,cash,cast,chat,chew,chip,chop,clap,clip,club,clue,";
            EasyList += "coat,code,coil,coin,coke,cold,comb,come,cone,cops,cord,core,corn,cost,cows,crab,crop,crow,cubs,cure,cute,dark,dart,dash,date,";
            EasyList += "deal,dean,dear,deck,desk,dice,diet,dine,dirt,dish,disk,dive,dock,dome,done,dose,down,drag,draw,drew,drop,drum,duck,dues,dump,";
            EasyList += "dust,east,easy,edit,exam,exit,face,fact,fail,fake,fame,fang,farm,fast,fate,fear,feat,fend,file,film,find,fine,fire,firm,fish,";
            EasyList += "fist,flat,fled,flew,foil,folk,fond,font,ford,fork,form,fort,from,gain,game,gate,gave,gear,give,glad,goat,gold,golf,gone,grab,";
            EasyList += "grew,grow,gulp,hair,half,halt,hand,hang,hard,hare,harm,hate,have,head,heal,heap,hear,heat,held,herd,hers,hide,hint,hold,hole,";
            EasyList += "home,honk,horn,hose,hugs,hums,hung,hurt,jail,joke,junk,king,lack,laid,lain,lame,lamp,land,lane,last,late,lead,life,like,line,";
            EasyList += "lips,long,lord,lost,love,lure,made,mail,main,male,mare,mark,mart,mask,mate,meal,mean,meat,mild,mile,milk,mind,mine,mint,mist,";
            EasyList += "moan,mole,move,nail,near,neat,neck,nest,node,nose,nude,ones,only,open,oral,orbs,oven,over,pace,pack,paid,pain,palm,pals,pane,";
            EasyList += "pang,pant,park,part,past,path,peak,peas,peck,perk,pets,pick,pile,pine,pits,plan,play,plot,plus,poke,pole,port,post,pure,puts,";
            EasyList += "race,rage,raid,rail,rain,rang,rank,rate,read,real,reap,rent,rest,rice,rich,ride,ring,ripe,rips,rise,road,roam,robs,rock,rode,";
            EasyList += "rods,rope,rose,rows,rude,rule,rung,runs,sack,safe,sage,said,sail,sake,sale,salt,same,sand,sang,sank,save,seat,self,semi,send,";
            EasyList += "sent,sewn,shed,ship,shoe,shop,shot,show,side,sign,sing,sink,slab,slam,slap,sled,slid,slim,slip,slow,soak,soap,soar,soda,sofa,";
            EasyList += "sold,some,song,sore,sort,soup,sour,spat,sped,spin,spit,spot,spun,star,stay,step,stop,suck,suit,sung,sunk,surf,swam,swim,tail,";
            EasyList += "take,tale,talk,tame,tank,tape,task,team,tear,term,then,thin,this,tick,tide,tied,ties,tile,time,tips,tire,told,tone,tore,town,";
            EasyList += "trip,trod,tubs,tune,turn,tyre,vase,vast,vine,wags,wake,walk,wand,want,ward,ware,warm,warn,wars,wash,wave,weak,wear,went,wife,";
            EasyList += "wind,wine,wing,wink,wise,wish,word,wore,work,worm,worn";

            string[] EasyWordListArray = EasyList.Split(',');
            
            int num = r.Next(0, 509);
            return (EasyWordListArray[num].ToUpper());                        
        }

        protected static string GenerateMediumWord()
        {
            Random r = new Random();

            string MedList = "abed,ably,achy,acme,acne,ahoy,airy,akin,also,alto,alum,amis,amok,amyl,apex,arch,arcs,arse,arty,ashy,auto,aves,awns,axed,";
            MedList += "axel,axis,axle,baht,balk,bane,bard,bare,bask,bays,beta,bias,bide,bile,bits,blah,blam,bled,blot,boar,bogs,bong,both,bout,boys,brag,";
            MedList += "bray,brew,brim,bros,brow,buck,bums,bunk,burn,bury,bust,busy,byte,cafe,cagy,calf,cane,cape,case,cave,caws,cent,chap,char,chef,chin,";
            MedList += "chit,chug,chum,cine,cite,city,clad,clam,clan,claw,clay,clog,clot,coal,coax,cogs,coir,cola,coma,cons,cope,copy,cork,cosy,cram,crap,";
            MedList += "crew,crib,cube,cues,cult,curb,curd,curl,curt,dabs,dame,damn,damp,dare,darn,dawn,daze,deaf,debt,deft,defy,demo,dent,deny,dewy,dial,";
            MedList += "dime,ding,dire,disc,diva,does,dons,dope,dorm,dote,dove,doze,dozy,drab,dreg,drib,drip,drug,dual,duct,duel,duet,duke,duly,dumb,dune,";
            MedList += "dung,dunk,dusk,duty,each,earl,earn,echo,emit,eras,etch,euro,evil,fade,fair,fare,fart,fawn,faze,felt,fern,fiat,figs,fila,fins,fits,";
            MedList += "flab,flag,flap,flaw,flip,flog,flop,flow,foam,fold,fore,foul,frag,frat,frog,fuel,fume,fund,furl,fury,fuse,gait,gale,gaps,garb,gasp,";
            MedList += "gaze,gems,germ,gift,girl,gist,glow,glue,glum,gnaw,goal,goer,goes,gore,gosh,gown,gram,gray,grey,grid,grim,grin,grip,gulf,guts,guys,";
            MedList += "hack,hags,hail,hale,halo,hark,harp,haul,hawk,haze,heck,heir,helm,help,hems,herb,hero,hike,hind,hips,hire,hive,holy,homy,hope,host,";
            MedList += "hour,howl,huge,hulk,hump,hunk,hunt,hurl,husk,hypo,iced,icon,idol,info,inky,into,iron,item,jade,jaws,jerk,jest,jobs,join,jolt,joys,";
            MedList += "jump,jury,just,jute,kept,keys,kind,kino,kite,knew,knit,knob,know,lace,lacy,lade,lady,lags,lair,lake,lakh,lamb,lard,lark,lash,lawn,";
            MedList += "laze,lazy,leaf,leak,lean,leap,left,lend,lens,lent,lets,liar,lice,lick,lied,lies,lift,limb,lime,limo,limp,lint,lion,lira,list,lite,";
            MedList += "load,loaf,loan,lock,lone,lore,lose,loud,luck,lump,lung,lurk,lust,mace,maid,make,malt,mane,many,mash,mast,math,maxi,maze,mead,meld,";
            MedList += "melt,mend,menu,meow,mesh,meta,mice,mids,mink,moat,mock,mode,mold,monk,more,most,moth,mown,much,muck,mule,musk,must,mute,name,nape,";
            MedList += "nerd,news,next,nice,nick,nite,nope,nosy,note,nova,nuke,numb,oaks,oars,obey,okay,omen,omit,once,opal,orcs,ores,oval,oxen,pact,page,";
            MedList += "pail,pale,pawn,pear,peat,pegs,peon,peso,pest,pier,ping,pink,pint,pity,plod,plug,plum,poem,poet,poly,pond,pony,pore,pork,pose,posh,";
            MedList += "pour,pray,prey,prod,prom,puke,puma,punk,push,quad,quit,quiz,raft,rake,ramp,rant,rapt,rash,rave,redo,rein,rely,ribs,rift,rink,riot,";
            MedList += "risk,rite,robe,role,rosy,rote,rove,ruby,rued,rues,ruin,rune,rush,rust,ruth,sane,scam,scan,scar,scum,seal,seam,sect,sexy,shin,sick,";
            MedList += "sigh,silk,silt,sire,size,skid,skin,skip,skit,slay,slew,slit,slob,slog,slot,slug,slum,slur,smog,smug,snag,snap,snip,snow,sock,soft,";
            MedList += "soil,sole,soul,sown,soya,spur,stab,stag,stem,stew,stir,stow,stub,stud,stun,such,sulk,sumo,sure,swan,swap,sync,tabs,tack,talc,tang,";
            MedList += "taxi,teak,temp,tend,tens,them,they,thru,thud,thug,thus,tier,tiny,toad,toed,toes,toil,tomb,tons,torn,tour,tows,toys,tram,trap,tray,";
            MedList += "trek,trim,troy,TRUE,tube,tuna,turf,tusk,twig,twin,twos,type,ugly,undo,unit,upon,urge,used,user,vain,vats,veil,vein,vest,vial,vibe,";
            MedList += "vice,view,vile,visa,vise,volt,vote,vows,wade,wage,wail,wait,warp,wasp,wavy,welt,wept,west,what,when,whip,whom,wide,wild,wimp,wipe,";
            MedList += "wire,wisp,with,woke,wolf,womb,wove,wrap,yard,yarn,yawn,year,yolk,your,yowl,yuan,yuck,zaps,zeta,zips,zone";

            string[] MedWordListArray = MedList.Split(',');

            int num = r.Next(0, 643);
            return (MedWordListArray[num].ToUpper());             
        }

        protected static string GenerateDifficultWord()
        {
            Random r = new Random();

            string ToughList = "abet,aeon,aero,ague,aide,aloe,avid,avow,awry,ayin,bach,barf,baud,bevy,bier,bios,blip,bloc,bode,bony,boxy,bran,brie,brig,";
            ToughList += "buoy,byre,calk,capo,carb,carp,cask,ceil,chao,chez,chow,ciao,clef,coda,coed,coif,colt,cory,coup,cove,cozy,crud,crux,cusp,cyan,cyst,";
            ToughList += "czar,daft,daub,deli,dibs,dike,doer,dole,dolt,dork,doth,dour,duce,duma,duos,dupe,dura,dyke,dyne,eaux,edgy,egad,envy,eons,epic,epos,";
            ToughList += "ergo,ergs,eros,erst,etas,expo,fain,faux,feud,fibs,fido,five,flax,flay,flea,flex,flit,flue,flux,foal,four,fowl,foxy,fray,fret,fuji,";
            ToughList += "gape,gash,gawk,gild,gimp,gits,glen,glib,glut,gnat,goad,gory,gout,grit,grub,gush,gust,gyro,haft,hart,hazy,heft,hemp,hewn,hilt,hoax,";
            ToughList += "hone,hued,hues,hymn,hype,iamb,icky,idea,idle,idly,imps,inch,ions,iota,ired,ires,irks,isle,itch,jabs,jews,jibe,jinx,jock,joey,jowl,";
            ToughList += "judo,juke,juts,kegs,kerb,kilo,kilt,kips,kith,knot,laud,lear,lest,levy,lewd,lieu,lima,lisp,loam,lobs,lode,loft,loin,lout,lube,luna,";
            ToughList += "lush,lute,lynx,lyre,mach,magi,maul,maws,mayo,mica,minx,mire,murk,muse,mush,myna,myth,nave,navy,nazi,newt,nips,noir,norm,oath,oats,";
            ToughList += "odes,ogle,ogre,oily,oink,okra,oldy,onus,onyx,opus,ouch,oust,peal,pert,pews,phew,pike,plea,plow,ploy,pout,prig,prim,pros,prow,puce,";
            ToughList += "puck,puny,pyre,qaid,quid,quip,rack,racy,rasp,raze,ream,repo,rife,rind,ritz,roil,romp,rout,ruly,runt,ruse,scab,scot,scry,sear,serf,";
            ToughList += "sham,shod,sift,silo,sith,skew,skim,snob,snog,snot,snub,snug,spar,spew,spud,sued,swab,swag,swat,sway,swig,taco,tarp,thaw,thou,tidy,";
            ToughList += "tofu,toga,tome,tong,trio,tsar,tuba,twas,tyke,typo,tyro,tzar,ulna,unto,urea,ursa,vale,veal,vent,verb,very,veto,vide,vied,void,wart,";
            ToughList += "wary,waxy,weal,wean,wham,whet,whey,whim,whoa,wick,wilt,wily,wiry,wist,writ,xyst,yang,yeah,yelp,yeti,yoga,yogi,yoke,yore,zeal,zero,";
            ToughList += "zest,zinc,zing";

            string[] ToughWordListArray = ToughList.Split(',');

            int num = r.Next(0, 339);
            return (ToughWordListArray[num].ToUpper());
        }
    }
}
