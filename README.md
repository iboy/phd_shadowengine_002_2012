# PhD Projects - ShadowEngine 002 2010-2012 - Unity 4.7.2 - Original multitouch iPad prototype.

Figures: Karaghiozis, Reiniger's horse, Reiniger's female figure. Wayang Kulit.

![screenshot](screenshot.png)

## Features: 

* Multipart, jointed 3D figures. 
* iPad publishing; 
* Multi-touch puppetry controls;
* Tests different approaches to figure assembly;
* Key bindings to experiment with angular constraints of root objects.
* Visual design changes


---- 

Changelog ShadowEngine 002
----

(1) Added multitouch support on all figures, currently works with orthographic cameras.

(2) Visual design: added several post-processing rendering effects and figure rendering controls:

* Vignetting: screen corner blur; subtle vignette shape and shadowing;
* Full screen blur;
* Depth of field (only works with a perspective camera) - attempting blur per object;
* Motion blur;
* Grayscale, silhouette and colour switching for coloured figures (In Karaghiozis scene key-bindings: Z, X and C )

(3) For demonstration purposes added a 'Touch-tracker', to visualise multiple touch points on live screen-captures (only works in Orthographic mode).

(4) For demonstration purposes added 'Camera Switcher', to toggle between 'Orthographic' and 'Perspective' camera types (key-bindings: P).

(5) For demonstration purposes added a keyboard utility to change at run-time 'Configurable Joint' settings: set angular limits on X, Y and Z. (default key-bindings: Q, W, E). Tweaking the 'angular motion limits' significantly changes the animatable and physics driven behaviours of the figures. The default settings for the main body part of the Karaghiozis figure's configurable joint's angular motion (per axis XYZ) is 'locked', 'free', 'locked'. This stops angular motion around the X and Z axis - note he doesn't bend at the waist and the piece is always upright. 'Locked', 'limited', 'limited', with no angular limit on Y - lets the figure rotate, using friction and momentum.

(6) Changed the mass of the two part Karaghiozis figure, seeking a better resting balance.