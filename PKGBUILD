#!/bin/bash
# Author: Vincent Gibault
pkgname=entrainementAthletisme
pkgver=1.2
pkgrel=1
pkgdesc="application pour l'athletisme (entrainement Vincent Gibault)"
arch=('x86_64')
url=https://github.com/VGib/EntrainementAthletisme
license=('GPL')
makedepends=('dotnet-sdk' 'dotnet-runtime' 'gendesk')
source=("${pkgname}"::'git+https://github.com/VGib/EntrainementAthletisme.git')
md5sums=('SKIP')
sha256sums=('SKIP')
b2sums=('SKIP')

prepare()
{
  gendesk --pkgname "$pkgname" --pkgdesc "$pkgdesc" --exec /opt/EntrainementAthletisme/EntrainementAthletisme
}

pkgver() {
  cd "$pkgname"
  printf "r%s.%s" "$(git rev-list --count HEAD)" "$(git rev-parse --short HEAD)"
}
cd
build() {
    cd ${srcdir}/entrainementAthletisme/EntrainementAthletisme
    dotnet publish EntrainementAthletisme/EntrainementAthletisme.csproj  -a x64  -o ${srcdir}/bin 
}

package() {
    mkdir -p ${pkgdir}/opt/
    cp -R ${srcdir}/bin ${pkgdir}/opt/EntrainementAthletisme 
    mkdir -p ${pkgdir}/usr/bin
    cd ${pkgdir}/usr/bin
    ln -s ../../opt/EntrainementAthletisme/EntrainementAthletisme EntrainementAthletisme
        
    # desktop entry
    cd $srcdir
    install -Dm644 "$pkgname.desktop" "$pkgdir/usr/share/applications/$pkgname.desktop"
    install -Dm644 "$pkgname.png" "$pkgdir/usr/share/pixmaps/$pkgname.png"
        }
